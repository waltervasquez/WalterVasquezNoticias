function ControllerNews($scope, $http, HttpPetitions) {
    var vm = this;
    HttpPetitions.petitionLoadInitial().then(function (data) {
        vm.dataNews = data;
    });
}