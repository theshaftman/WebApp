var ViewModel = function () {
    var self = this;
    self.loadPage = function (currentHash) {
        if (currentHash.indexOf("?") > -1) {
            hideAreas();
            currentHash = currentHash.split("?")[1];
            document.getElementById(currentHash).style.display = "block";
        }
    }

    function hideAreas() {
        document.getElementById("exteriorRepair").style.display = "none";
        document.getElementById("interiorRepair").style.display = "none";
        document.getElementById("bathRepair").style.display = "none";
    }
};