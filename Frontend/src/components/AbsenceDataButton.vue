<template>
    <div class="wrapper">
        <div>
            <H3>{{ studentName }}</H3>
        </div>
        <div>
            <div>
                {{ fromDate }}
            </div>
            <div v-if="toDate">
                {{ toDate }}
            </div>
        </div>
        <div v-if="reason">
            {{ reason }}
        </div>
    </div>
</template>

<script>
export default {
    name: "AbsenceDataButton",
    props: {
        studentName: String,
        fromDate: Date,
        toDate: Date,
        reason: String
    }
}
</script>
<style scoped>
.wrapper {
    padding: 20px;
    background-color: #ffff;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.16) 0px 3px 6px;
}
</style>