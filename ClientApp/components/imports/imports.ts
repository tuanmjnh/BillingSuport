import Vue from 'vue';

import { Component } from 'vue-property-decorator';

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
    data: TEST[] = [];
    mounted() {
        fetch('api/Imports/GetData')
            .then(response => response.json() as Promise<TEST[]>)
            .then(data => {
                this.data = data;
            });
    }
}
