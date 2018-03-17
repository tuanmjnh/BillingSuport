import './css/site.css';
//import 'bootstrap';
import Vue from 'vue';
import VueRouter from 'vue-router';
import Component from 'vue-class-component';
//filter
import './components/app/filter.ts';
//Vuetify
import './stylus/main.styl';
import Vuetify from 'vuetify';
//import 'vuetify/dist/vuetify.min.css';
//import 'babel-polyfill';

Vue.use(VueRouter);
Vue.use(Vuetify);
const routes = [
    { path: '/', component: require('./components/home/home.vue.html') },
    { path: '/counter', component: require('./components/counter/counter.vue.html') },
    { path: '/fetchdata', component: require('./components/fetchdata/fetchdata.vue.html') },
    { path: '/imports', component: require('./components/imports/imports.vue.html') },
    { path: '/managertichhop', component: require('./components/managertichhop/managertichhop.vue.html') }
];

new Vue({
    el: '#app-root',
    router: new VueRouter({ mode: 'history', routes: routes }),
    render: h => h(require('./components/app/apptify.vue.html'))//render: h => h(require('./components/app/app.vue.html'))
});
