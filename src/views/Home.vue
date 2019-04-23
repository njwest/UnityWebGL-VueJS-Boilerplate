<template>
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

    <!-- Unstyled text input + button -->
    <input type="text" v-model="textInput" description="Input text here to send to Unity">
    <button @click="inputText">
      Send a string to Unity
    </button>
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
      textInput: ''
    }
  },
  methods: {
    sendText() {
      this.$refs.myInstance.message('Text', 'SetText', this.textInput)
    }
  }
}
</script>
