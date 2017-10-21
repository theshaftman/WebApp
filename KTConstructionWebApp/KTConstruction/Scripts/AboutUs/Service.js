var Service = (function () {
    var self = this;
    self.ajaxRequest = function (requestType, url, data) {
        return $.ajax({
            type: requestType,
            url: url,
            dataType: "json",
            data: data
        });
    };
    self.projectNumbers = {
        allProjects: 18,
        currentProjects: 9,
        interiorRepairs: 7,
        exteriorRepairs: 5,
        bathRepairs: 6
    };
    self.setIntervalTime = 70;
    return {
        ajaxRequest: self.ajaxRequest,
        projectNumbers: self.projectNumbers,
        setIntervalTime: self.setIntervalTime
    };
}());