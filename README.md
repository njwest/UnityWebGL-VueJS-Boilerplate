# UnityWebGL VueJS Boilerplate

This is a boilerplate **Unity WebGL** ++ **VueJS** web app with **VueX && **vue-router** pre-installed.

This project takes advantage of the Unity3d web container wrapper component provided by
@votetake's [vue-unity-webgl](https://github.com/votetake/vue-unity-webgl) Node package.

## Directory Structure

`./public/Build` && `./public/TemplateData` - the templates/JS functions of a bare Unity3D WebGL project.

## Send a string from VueJS to the Unity Scene

The Unity scene contains only a lean 3D plane and a text object.

Text can be sent to the text object in the Unity game instance via the `@click` method in `./src/views/Home.vue`:

```JavaScript
// $refs.myInstance === <unity ref="myInstance">
this.$refs.myInstance.message('Text', 'SetText', this.textInput)
```

## Project setup
```
npm install
```

### Compiles and hot-reloads for development
```
npm run serve
```

### Compiles and minifies for production
```
npm run build
```

### Run your tests
```
npm run test
```

### Lints and fixes files
```
npm run lint
```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).
