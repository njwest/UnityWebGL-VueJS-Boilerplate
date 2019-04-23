<template>
  <div class="">
    <unity src="/Build/WebGL-Test.json" width="1000" height="600" unityLoader="/Build/UnityLoader.js" ref="myInstance"></unity>
    <input type="text" v-model="textInput" description="Input text here to send to Unity">

    <button @click="inputText">My Button >:(</button>
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
    sendText () {
      this.$refs.myInstance.message('Text', 'SetText', this.textInput)
    }
  }
}
</script>
