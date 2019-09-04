function applyFilterByName(data) {

    var dataSource = (data.value !== "") ?
        DevExtremeDataSourceMapper.asGetByFullNameRouteDataSource(data.value) :
        DevExtremeDataSourceMapper.asGetRouteDataSource();

    $("#gridContainer").dxDataGrid("instance").option("dataSource", dataSource);

}
function applyFilterByDateOfBirth(data) {

    var dataSource = (data.value !== null) ?
        DevExtremeDataSourceMapper.asGetByDateOfBirthRouteDataSource(data.value) :
        DevExtremeDataSourceMapper.asGetRouteDataSource();

    $("#gridContainer").dxDataGrid("instance").option("dataSource", dataSource);

}
function applySorting(data) {
    const UNSORTED_VALUE = 0;
    var dataSource = (data.value !== UNSORTED_VALUE) ?
        DevExtremeDataSourceMapper.asGetSortedRouteDataSource(data.value) :
        DevExtremeDataSourceMapper.asGetRouteDataSource();

    $("#gridContainer").dxDataGrid("instance").option("dataSource", dataSource);

}