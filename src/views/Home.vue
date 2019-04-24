<template>
  <div class="">
    <div class="">
      <!--
      The Unity Container.
      Look in the src of npm-modules/vue-unity/webgl/ after npm installing for the mechanics of this custom component
      -->
      <unity
        src="/Build/WebGL-Test.json"
        width="1000"
        height="600"
        unityLoader="/Build/UnityLoader.js" ref="myInstance"
      >
      </unity>
    </div>
    <div class="">
      <!-- Unstyled text input + button -->
      <input v-model="textInput" placeholder="Enter a string to send to Unity">
      <button @click="sendText">
        Send a string to Unity
      </button>
    </div>
  </div>
</template>
<script>
import Unity from 'vue-unity-webgl'

export default {
  name: 'home',
  components: {
    Unity
  },
  data() {
    return {
      textInput: "String to send"
    }
  },
  methods: {
    sendText() {
      console.log(this.textInput)
      this.$refs.myInstance.message('Text', 'SetText', this.textInput)
    }
  }
}
</script>
