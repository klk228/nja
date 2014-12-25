angular.module('rule1', [])
.factory('discounter', ['$http', function ($http) {


    var conn = "http://localhost:46770/api/wapi/";
     var discs = {
        QQQ: 0.1,
        ZZZ: 0.2,
        WWW: 0.3
    };
    var apply = function (amount, pname) {
        return  amount * (1 - discs[pname]);
    };

    var disc = function ( pname) {
        return discs[pname];
    };

    var refresh = function (pname) {
        var url = conn + pname;
        alert(url);
        var a= $http.get(url);
        a.success(function (data) {
            alert("1");

        });
        return 0.1;/*return $http.jsonp(url).success(function (data) {
            alert(data);
            
        });
        */
    };

    refresh("QQQ");
    return {
        disc: disc,
        apply: apply,
        refresh: refresh
    };
}]);