var GuestBook = {
    Page: {
        Home: {
            Index: {

            }
        },
        GuestBook: {
            Index: {
                Send: function () {
                    var name = $("#Name").val();
                    var surname = $("#Surname").val();
                    var email = $("#Email").val();
                    var message = $("#Message").val();

                    if (name.length < 2 || name.length > 50) {
                        alert("Adınız 2 karakterden küçük 50 karakterden fazla olamaz, tatlım.. :* <3 ")
                        return;
                    }

                    if (surname.length < 2 || surname.length > 50) {
                        alert("Soyadınız 2 karakterden küçük 50 karakterden fazla olamaz, tatlım.. :* <3 ")
                        return;
                    }

                    else if (email.length < 6 || email.length > 345) {
                        alert("Emailiniz 6 karakterden küçük 345 karakterden fazla olamaz, tatlım.. :* <3 ")
                        return;
                    }
                    else if (!GuestBook.Helper.IsEmail(email)) {
                        alert("Email adresi hatalı, tatlım.. :* <3 ")
                        return;
                    }
                    else if (message.length < 2 || message.length > 1024) {
                        alert("Mesajınız 2 karakterden küçük 1024 karakterden fazla olamaz, tatlım.. :* <3 ")
                        return;
                    }

                    $("#GuestBook-Index-Form").hide();
                    $("#GuestBook-Index-Sending").show();

                    var data = {
                        Name: name,
                        Surname: surname,
                        Email: email,
                        Message: message
                    };

                    var json = JSON.stringify(data);

                    $.ajax({
                        type: "POST",
                        url: "/GuestBook/SendAction",
                        data: json,
                        success: GuestBook.Page.GuestBook.Index.Send_Callback,
                        error: GuestBook.Page.GuestBook.Index.Send_Callback_Error,
                        dataType: "json",
                        contentType: "application/json;charset=utf-8"
                    });
                },
                Send_Callback: function (result) {

                    $("#GuestBook-Index-Sending").hide();
                    $("#GuestBook-Index-Sent").show();
                    console.log(result);
                },
                Send_Callback_Error: function (result) {
                    console.log(result);
                }
                
            }
        }
    },
    Helper: {
        IsEmail: function (email) {
            var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            return regex.test(email);
        }
    }
}