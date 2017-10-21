var ViewModel = function () {
    var self = this;
    self.loadPage = function () {
        //$('#sightseeing').waypoint(function (direction) {
        //    alert("visible");
        //});
        var numbers = Service.projectNumbers;
        loadNumbers("allProjects", numbers.allProjects);
        loadNumbers("interiorRepairs", numbers.interiorRepairs);
        loadNumbers("exteriorRepairs", numbers.exteriorRepairs);
        loadNumbers("bathRepairs", numbers.bathRepairs);
        loadNumbers("currentProjects", numbers.currentProjects);
    }

    function loadNumbers(givenId, givenMaxNumber) {
        var dfd = $.Deferred();
        var currentNumber = 0;
        var currentInterval = setInterval(function () {
            if (currentNumber == givenMaxNumber) {
                clearInterval(currentInterval);
            }
            document.getElementById(givenId).innerText = currentNumber
            currentNumber += 1;
        }, Service.setIntervalTime);
        return dfd.resolve(true);
    }
};