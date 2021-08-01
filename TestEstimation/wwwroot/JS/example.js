function JSAlert() {
    $('#dialog').toggleClass("show-dialog");
    $("#dialog").dialog({
        resizable: false,
        height: 200,
        width: 350,
        modal: true,
        buttons: {
            "Save": function () {
                notifyMe();
                //SayHelloJS("Kowshik");
                $(this).dialog("close");
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
}


function notifyMe() {
    // Let's check if the browser supports notifications
    if (!("Notification" in window)) {
        alert("This browser does not support desktop notification");
    }

    // Let's check whether notification permissions have already been granted
    else if (Notification.permission === "granted") {
        // If it's okay let's create a notification
        var notification = new Notification("Hi there!");
    }

    // Otherwise, we need to ask the user for permission
    else if (Notification.permission !== "denied") {
        Notification.requestPermission().then(function (permission) {
            // If the user accepts, let's create a notification
            if (permission === "granted") {
                var notification = new Notification("Hi there!");
            }
            else {
                alert("You are rude bruh !!! :( ");
            }
        });
    }
    else {
        alert("You are rude bruh !!! :( ");
    }

    // At last, if the user has denied notifications, and you
    // want to be respectful there is no need to bother them any more.
}


function SayHelloJS(name) {
    DotNet.invokeMethodAsync("TestEstimation", "SayHelloCS", name)
        .then(data => alert("success"), reason => alert(reason));
}