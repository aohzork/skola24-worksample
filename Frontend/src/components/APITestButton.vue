<template>
    <div>
        <input v-model="inputSchoolName" type="text" placeholder="Search school to retrieve absence" />
        <button @click="getData()">Get Absence</button>
        <div>{{ responseData }}</div>
    </div>
</template>

<script>
import absenceService from '../apiService/absenceService';



export default {
    data() {
        return {
            responseData: null,
            inputSchoolName: "",
        };
    },
    methods: {
        async getData() {
            const respone = await absenceService.getAbsenceBySchool(this.inputSchoolName);
            console.log(respone.data);
            this.responseData = respone.data;
        }
    }
}
</script>
