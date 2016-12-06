'use strict';

registrationModule.controller('accountController',
    function($scope, accountRepository) {
        $scope.save = function(student) {
            accountRepository.save(student);
        };
    });