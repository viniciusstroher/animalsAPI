var authToken;
var loginUrl = "../";
try {
    authToken = sessionStorage.getItem("AuthToken");
    if(authToken === null || authToken === "") window.location.href = loginUrl;
}
catch(e) {
    window.location.href = loginUrl;
}

$(function() {
    $("#logout").click(function() {
        sessionStorage.clear();
        window.location.href = loginUrl;
    });
    var url = "../api_docs/v1/";

    if(window.SwaggerTranslator)
        window.SwaggerTranslator.translate();

    function log() {
        if("console" in window)
            console.log.apply(console, arguments);
    }

    window.swaggerUi = new SwaggerUi({
        url: url,
        dom_id: "swagger-ui-container",
        supportedSubmitMethods: ["get", "post", "put", "delete", "patch"],
        onComplete: function(swaggerApi, swaggerUi) {
            if(window.SwaggerTranslator)
                window.SwaggerTranslator.translate();

            $("pre code").each(function(i, e) {
                hljs.highlightBlock(e);
            });

            swaggerApi.clientAuthorizations.add("AuthToken", new SwaggerClient.ApiKeyAuthorization("AuthToken", authToken, "header"));
        },
        onFailure: function(data) {
            log("Unable to Load SwaggerUI");
        },
        docExpansion: "none",
        apisSorter: "alpha",
        showRequestHeaders: false
    });

    window.swaggerUi.load();
});