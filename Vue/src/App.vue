<template>
  <div id="app">
    <Home />
  </div>
</template>

<script>
import "devextreme/dist/css/dx.common.css";
import "devextreme/dist/css/dx.material.blue.light.compact.css";
import config from "devextreme/core/config";
import Home from "./components/Home.vue";

export default {
  name: "app",
  components: {
    Home
  },
  created() {
    config({
      editorStylingMode: "filled"
    });
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>
