var wsUri = "wss://localhost:44337/admin";

var singleton = (function () {
    var instance;
    function init() {
        websocket = new WebSocket(wsUri);
        websocket.onopen = function (evt) {
            console.log("CONECTED");
        };
        websocket.onclose = function (evt) {
            console.log("DISCONECTED");
        };
        websocket.onmessage = function (evt) {
            console.log(evt);
            var obj = strToObj(evt.data);
            if (obj.data.success && obj.data.key == "invoice") {
                changeOrder();
                if (window.location.href == "https://localhost:44328/admin/neworder") {
                    addInvoidSocket(obj);
                }
            }
            if (obj.data.success && obj.data.key == "newuser") {
                changeEmailUser(0);
            }
            if (obj.data.success && obj.data.key == "newemail") {
                changeEmailUser(1);
            }
        };
        websocket.onerror = function (evt) {
            websocket = new WebSocket(wsUri);//connect again
        };
    }
    return {
        getInstance: function () {
            if (!instance) {
                instance = init();
            }
            return instance;
        }
    };
})();

//function onOpen(evt) {
//    writeToScreen("CONNECTED");
//}

//function onClose(evt) {
//    writeToScreen("DISCONNECTED");
//}

//function onMessage(evt) {
//    writeToScreen('onMessage');
//    console.log(evt);
//    changeOrder();
//    if (evt.data.success && evt.data.key == "invoice") {
//        changeOrder();
//    }
//}

//function onError(evt) {
//    writeToScreen('onError');
//    onOpen();
//}

//function doSend(message) {
//    writeToScreen("SENT: " + message);
//    websocket.send(message);
//}

//function writeToScreen(message) {
//    console.log(message);
//}

window.addEventListener("load", singleton.getInstance(), false);