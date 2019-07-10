
var Subscriber = {
    subscribe: function () {
        EventManager.subscribe("btnClicked", this.sayHelloAgain);
    },
    sayHello: function (data) {
        alert('hello' + data);
    }
};
//Subscriber.subscribe();