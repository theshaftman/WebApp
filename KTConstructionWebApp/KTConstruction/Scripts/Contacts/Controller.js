var Controller = (function () {
    var self = this;
    var model = new ViewModel();
    self.init = function () {
        model.loadPage();
    };
    return {
        init: self.init
    };
}());
