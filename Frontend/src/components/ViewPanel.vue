<template>
    <div class="view-panel">
        <slot name="child"></slot>
    </div>
</template>

<script>
export default {
    name: "ViewPanel",
}
</script>

<style scoped>
.view-panel {
    padding: 15px;
    background-color: #ffff;
    border-radius: 10px;
    box-shadow: rgba(0, 0, 0, 0.16) 0px 3px 6px;
}
</style>    