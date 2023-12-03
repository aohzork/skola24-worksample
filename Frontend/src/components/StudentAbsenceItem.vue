<script setup>
import { formatDate } from '../formatters.js'
</script>

<template>
    <div class="wrapper">
        <div>
            <h3>{{ toUpperCase(studentName) }}</h3>
        </div>
        <div class="dates">
            <div>
                {{ formatDate(fromDate) }}
            </div>
            <div>
                -
            </div>
            <div>
                {{ toDate ? formatDate(toDate) : "Tillsvidare" }}
            </div>
        </div>
        <div class="reason-box">
            Anledning: {{ reason ? reason : "Saknas" }}
        </div>
    </div>
</template>

<script>
export default {
    name: "StudentAbsenceItem",
    props: {
        studentName: String,
        fromDate: Date,
        toDate: String,
        reason: String
    },
    methods: {
        toUpperCase(name) {
            return name.toUpperCase();
        },
    }
}
</script>

<style scoped>
.wrapper {
    padding: 20px;
    background-color: #ffff;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.16) 0px 3px 6px;
    height: 140px;
}

.dates {
    padding-top: 5px;
}

.dates :nth-child(-n+2) {
    float: left;
    padding-right: 20px;
}

.reason-box {
    padding-top: 15px;
}
</style>