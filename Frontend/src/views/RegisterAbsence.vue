<script setup>
import AddAbsenceButton from '../components/Buttons/AddAbsenceButton.vue';
import StudentAbsenceItem from '../components/StudentAbsenceItem.vue';
import { getRandomStudent } from '../dataHandler';
</script>

<template>
    <div>
        <h1>Registrera frånvaro</h1>
    </div>
    <div class="absence">
        <div v-for="item in absenceItems" :key="item.id" class="col-4">
            <StudentAbsenceItem :studentName="item.name" :fromDate="item.dateFrom.toString()"
                :toDate="item.toDate ? item.toDate.toString() : undefined" :reason="item.reason" />
        </div>
        <div class="col-4">
            <AddAbsenceButton :iconClass="'bi bi-plus-circle'" :bgColor="'var(--c-c-success)'"
                :buttonText="'Registrera frånvaro'" @clickAddAbscence="addAbsence()" />
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            absenceItems: []
        };
    },
    methods: {
        addAbsence() {
            const student = getRandomStudent();
            this.absenceItems.push(student);
        }
    }
}
</script>