angular.module('product1', ['rule1'])
.controller('ProductController', ['discounter', function (discounter) {
    this.quantity = 1;
    this.cost = 20;
    this.pname = "QQQ";
    this.pnames = ["QQQ","ZZZ","WWW"];
    this.disc = function () { return discounter.disc(this.pname); };
    this.total = function () { return discounter.apply(this.quantity * this.cost, this.pname);};
    this.refresh = function () { return discounter.refresh( this.pname); };
    this.pay = function pay() {
        window.alert("Thanks!");
    };
}
]);