import moment from 'moment';
import Vue from 'vue';

Vue.filter('capitalize', function (value: any) {
    if (!value) return ''
    value = value.toString()
    return value.charAt(0).toUpperCase() + value.slice(1)
});
Vue.filter('formatDate', function (value: any, format = "DD/MM/YYYY hh:mm") {
    if (value) {
        return moment(String(value)).format(format)
    }
});