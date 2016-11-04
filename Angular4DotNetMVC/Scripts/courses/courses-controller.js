registrationModule.controller("CoursesController", function ($scope,bootstrappedData) {
    $scope.courses = bootstrappedData.courses;
    //$scope.instructors = bootstrappedData.instructors;
});