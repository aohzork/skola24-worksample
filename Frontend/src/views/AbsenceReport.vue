<script setup>
import ViewPanel from '../components/ViewPanel.vue';
import absenceService from '../apiService/absenceService';
import SearchButton from '../components/Buttons/SearchButton.vue';
</script>

<template>
    <div class="col-12">
        <h1>Frånvarokollen</h1>
    </div>
    <div class="col-12">
        <h3>-Få koll på skolan och elevernas frånvaro </h3>
    </div>
    <div class="col-6">
        <div class="col-4">
            <p>Total frånvaro på</p>
            <p>{{ schoolName ? schoolName : "Ingen skola vald" }}</p>
        </div>
        <div class="col-2">
            <ViewPanel>
                <template v-slot:child>
                    {{ totalSchoolAbsence ? `${totalSchoolAbsence} h` : 0 }}
                </template>
            </ViewPanel>
        </div>
    </div>
    <div class="col-6">
        <div class="col-4">
            <input v-model="currentSchoolName" type="text" placeholder="Ange skola..." />
        </div>
        <div class="col-2 search">
            <SearchButton :iconClass="'bi bi-search'" :bgColor="'#FFC72C'" @clickSearch="getData()" />
        </div>
    </div>
    <div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            totalSchoolAbsence: null,
            currentSchoolName: "",
            schoolName: "",
        };
    },
    methods: {
        async getData() {
            const respone = await absenceService.getAbsenceBySchool(this.currentSchoolName);
            console.log(respone.data);
            this.totalSchoolAbsence = respone.data;
            this.schoolName = this.currentSchoolName;
        }
    }
}
</script>

<style scoped>
input {
    padding: 15px 10px 15px 10px;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.16) 0px 3px 6px;
    border-color: #f0f0f0;
}
</style>