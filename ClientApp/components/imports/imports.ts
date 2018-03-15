import Vue from 'vue';
import { Component } from 'vue-property-decorator';

// import Vuetable from 'vuetable-2/src/components/Vuetable';
// import VuetablePagination from 'vuetable-2/src/components/VuetablePagination';
// import VuetablePaginationInfo from 'vuetable-2/src/components/VuetablePaginationInfo';
// Vue.use(Vuetable)
import * as Vuetable from 'vuetable-2';
Vue.component("vuetable", Vuetable.Vuetable)
Vue.component("vuetable-pagination", Vuetable.VuetablePagination)

interface TEST {
    id: string;
    name: string;
    levels: number;
    money: number;
    time: Date;
}

@Component({
    // filters: {
    //     capitalize: function (value:any) {
    //       if (!value) return ''
    //       value = value.toString()
    //       return value.charAt(0).toUpperCase() + value.slice(1)
    //     }
    //   }
})

export default class ImportsComponent extends Vue {
    //data: TEST[] = [];
    // mounted() {
    //     fetch('api/Imports/GetData')
    //         .then(response => response.json() as Promise<TEST[]>)
    //         .then(data => {
    //             this.data = data;
    //         });
    // }
    data() {
        return { fields: ['name', 'levels', 'money', 'time'] }
    }
}
