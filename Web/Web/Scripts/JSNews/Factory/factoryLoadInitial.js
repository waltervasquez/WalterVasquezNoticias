app.factory('HttpPetitions', ['$q', '$http', 'API_SERVER', function ($q, $http, API_SERVER) {
    function petitionLoadInitial() {
        var defer = $q.defer();
        var url = API_SERVER.API_DEVELOPMENT + 'getListNews';
        $http.get(url).
          then(function (response) {
              console.log(response.data);
              defer.resolve(response.data);
          });
        return defer.promise;
    }

    return {
        petitionLoadInitial: function () {
            return petitionLoadInitial();
        }
    };

}]);
