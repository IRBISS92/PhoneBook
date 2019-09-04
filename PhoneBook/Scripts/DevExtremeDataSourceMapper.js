class DevExtremeDataSourceMapper {
    static asGetRouteDataSource() {
        return DevExpress.data.AspNet.createStore({
            key: "Id",
            loadUrl: `/api/Employees/Get/`
        });
    }
    static asGetByFullNameRouteDataSource(parameter) {
        return DevExpress.data.AspNet.createStore({
            key: "Id",
            loadUrl: `/api/Employees/GetByFullName/`,
            loadParams: { fullname: parameter }
        });
    }
    static asGetByDateOfBirthRouteDataSource(parameter) {
        return DevExpress.data.AspNet.createStore({
            key: "Id",
            loadUrl: `/api/Employees/GetByDateOfBirth/`,
            loadParams: { dateOfBirth: parameter }
        });
    }
    static asGetSortedRouteDataSource(parameter) {
        return DevExpress.data.AspNet.createStore({
            key: "Id",
            loadUrl: `/api/Employees/GetSorted/`,
            loadParams: { sortType: parameter }
        });
    }

}