<script setup>
import PageNavButton from './components/PageNavButton.vue';
</script>

<template>
  <main>
    <router-view></router-view>
    <div v-if="$route.path === '/'">
      <div class="col-12">
        <h1>Skola24 arbetsprov</h1>
      </div>
      <div class="col-3">
        <PageNavButton :bgColor="'#4ade80'" :iconClass="'bi bi-calendar3'" :btnText="'Registrera frånvaro'"
          :uri="'/register-absence'" />
      </div>
      <div class="col-3">
        <PageNavButton :bgColor="'#FFC72C'" :iconClass="'bi bi-clock'" :btnText="'Frånvarokollen'"
          :uri="'/absence-report'" />
      </div>
      <div class="col-3"> </div>
      <div class="col-3"> </div>
    </div>
  </main>
</template>

<style scoped></style>
