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
            this.$emit("clickAddAbscence");
        }
    }
}
</script>

<style scoped>
.wrapper {
    width: 100%;
    height: 6em;
    display: flex;
    align-items: center;
    border-radius: 5px;
    border-color: var(--c-c-success);
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
    font-size: 4em;
    color: white;
}

.text {
    flex: 2;
    padding-right: 10px;
    font-size: 2em;
    color: white;
}

@media (min-width: 998px) {
    .wrapper {
        height: 10.4em;
    }

    .button-icon-area {
        font-size: 5em;
    }

    .text {
        font-size: 2em;
    }
}
</style>