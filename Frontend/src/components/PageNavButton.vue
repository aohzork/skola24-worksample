<template>
    <button @click="handleButtonClick">
        <div class="button-content">
            <div class="button-icon-area" :style="{ backgroundColor: bgColor }"><i :class="iconClass" :btnText="text"></i>
            </div>
            <div class="text-area">
                <h2>{{ btnText }}</h2>
            </div>
        </div>
    </button>
</template>

<script>
export default {
    name: "PageNavButton",
    methods: {
        handleButtonClick() {
            this.$router.push("/register-absence");
        }
    },
    props: {
        iconClass: String,
        bgColor: String,
        btnText: String,
    }
}
</script>

<style scoped>
button {
    padding: 20px;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.16) 0px 3px 6px;
    border: 0px;
    background-color: white;
    cursor: pointer;
}

button:hover {
    box-shadow: rgba(0, 0, 0, 0.25) 0px 6px 12px;
}

.button-content {
    width: 200px;
    display: flex;
    flex-direction: column;
}

.button-icon-area {
    height: 170px;
    border-radius: 4px;
    color: white;
    font-size: 9em;
    padding-top: 15px;
}

.text-area {
    height: 30px;
    margin-top: 15px;
    text-align: left;
}

@media (max-width: 998px) {
    .button-content {
        flex-direction: row;
    }

    .text-area {
        height: 30px;
        margin-top: 13px;
        padding-left: 15px;
        text-align: left;
    }

    .button-icon-area {
        width: 45px;
        height: 45px;
    }

    button {
        padding: 10px;
    }
}
</style>