<template>
  <unity src="static/Build/game.json" width="1000" height="600" unityLoader="static/Build/UnityLoader.js" ref="uInstance"></unity>
</template>
<script>
import Web3 from "web3"
import Unity from 'vue-unity-webgl'

export default {
  name: 'home',
  data() {
    return {
      web3: null
    }
  },
  created() {
    this.web3 = new Web3(web3.currentProvider)
  },
  methods: {
    onClick () {
      this.$refs.myInstance.message("object", "method", "param")
    }
  }
}
</script>



<script>
import Unity from 'vue-unity-webgl'

new Vue({
  methods: {
    onClick () {
      this.$refs.uInstance.message("object", "method", "param")
    }
  }
})
</script>
