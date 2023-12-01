<script setup>
import APITestButton from './components/APITestButton.vue';
import AbsenceDataButton from './components/AbsenceDataButton.vue';
import PageNavButton from './components/PageNavButton.vue';
import ViewPanel from './components/ViewPanel.vue';
// import HelloWorld from './components/HelloWorld.vue'
</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="125" height="125" />
    <h1>Hello</h1>
    <div class="wrapper">
      <HelloWorld msg="You did it!" />
    </div>
  </header>

  <main>
    <router-view></router-view>
    <div v-if="$route.path !== '/register-absence'">
      <APITestButton />
      <ViewPanel>
        <template v-slot:child>
          <Child :prop1="Hello">Hello</Child>
        </template>
      </ViewPanel>
      <AbsenceDataButton :studentName="'Student'" :fromDate="new Date()" reason="'Vill ej uppge'" />
      <PageNavButton :bgColor="'#00FF00'" :iconClass="'bi bi-calendar3'" />
      <!-- <TheWelcome /> -->
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
