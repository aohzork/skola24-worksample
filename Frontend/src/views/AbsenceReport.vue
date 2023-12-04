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
            <SearchButton :iconClass="'bi bi-search'" :bgColor="'#FFC72C'" @clickSearch="fetchAbsenceData()" />
        </div>
    </div>
    <div class="col-12 divider">
    </div>
    <div class="col-12">
        <table>
            <thead>
                <tr>
                    <td>Id</td>
                    <td>Elev</td>
                    <td>Frånvarotimmar</td>
                </tr>
            </thead>
            <tbody>
                <tr v-for="stud in students" :key="stud.id">
                    <td>{{ stud.id }}</td>
                    <td>{{ stud.name }}</td>
                    <td>{{ stud.totalAbsence }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
export default {
    data() {
        return {
            totalSchoolAbsence: null,
            currentSchoolName: "",
            schoolName: "",
            students: []
        };
    },
    methods: {
        async fetchAbsenceData() {
            try {

                const respone = await absenceService.getAbsenceBySchool(this.currentSchoolName);
                console.log(respone.data);
                this.totalSchoolAbsence = respone.data;
                this.schoolName = this.currentSchoolName;

                const studentsResponse = await absenceService.getStudentsAbsenceBySchool(this.currentSchoolName)
                this.students = studentsResponse.data;
            }
            catch (error) {
                console.error("Error fetching absencedata: ", error);
            }
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
    width: 100%;
}

.divider {
    border-top: 3px solid #FFC72C;
}

table,
th,
td {
    border: 1px solid #FFC72C;
    border-collapse: collapse;
    padding: 5px;
}
</style>