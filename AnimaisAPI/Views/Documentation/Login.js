$(document).ready(function() {
    sessionStorage.clear();
    $("#btnAutenticar").click(function() {
        $(".login-message").empty();
        var token = $("#login-token").val();
        $.ajax({
            type: "GET",
            url: "Authorize",
            headers: {
                "AuthToken": token
            }
        }).done(function(data) {
            sessionStorage.setItem("AuthToken", token);
            window.location.href = "Sandbox/";
        }).fail(function(data, ex, e2e) {
            try {
                var apiMessage = JSON.parse(data.responseText).Message;
                $(".login-message").text(apiMessage);
            }
            catch(ex) {
                $(".login-message").text("Ocorreu um problema no momento, tente novamente mais tarde.");
            }
        });
    });
});