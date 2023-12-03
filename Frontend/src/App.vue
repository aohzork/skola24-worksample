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
        <PageNavButton :bgColor="'#fde047'" :iconClass="'bi bi-clock'" :btnText="'Frånvarokollen'"
          :uri="'/absence-report'" />
      </div>
    </div>
  </main>
</template>

<style scoped>
header {
  line-height: 1.5;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }
}
</style>
