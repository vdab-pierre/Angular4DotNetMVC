'use strict';
registrationModule.controller("coursesController", function ($scope, coursesRepository) {
    coursesRepository.get().then(function(courses) {$scope.courses=courses});
});