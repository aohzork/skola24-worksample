<template>
    <button class=" wrapper" :style="{ backgroundColor: bgColor }" @click="handleButtonClick">
        <div class=" button-content">
            <div class="button-icon-area grid-3"><i :class="iconClass"></i></div>
            <div v-if=buttonText class="text grid-9">{{ buttonText }}</div>
        </div>
    </button>
</template>

<script>
export default {
    name: "AddAbscenceButton",
    props: {
        iconClass: String,
        bgColor: String,
        buttonText: String
    },
    methods: {
        handleButtonClick() {
            this.$emit("clickSearch");
        }
    }
}
</script>

<style scoped>
.wrapper {
    width: 100%;
    display: flex;
    align-items: center;
    border-radius: 5px;
    border-color: var(--c-c-warning);
    padding: 15px 10px 15px 10px;
}

button {
    background-color: gray;
    cursor: pointer;
}

.button-content {
    width: 100%;
    display: flex;
    align-items: center;
}

.button-icon-area {
    flex: 1;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 2em;
    color: white;
}

.text {
    flex: 2;
    padding-right: 10px;
    color: white;
}

@media (min-width: 998px) {
    .text {
        font-size: 1em;
    }

    .wrapper {
        padding: 7.5px 5px 7.5px 5px;
    }
}
</style>