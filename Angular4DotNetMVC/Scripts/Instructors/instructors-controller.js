'use strict';
registrationModule.controller("instructorsController", function ($scope, instructorRepository) {
    instructorRepository.get().then(function (instructors) { $scope.instructors = instructors });
});