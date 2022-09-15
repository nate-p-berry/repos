//import { createApp } from 'vue'
//import App from './App.vue'

//createApp(App).mount('#app')

//// Language: typescript
//// Path: Assignment10-2\src\App.vue
//    < template >
<div id="app">
    <h1 style="text-align: center" >Assignment 10-2</h1>
    <h2>My name is {{ name }}</h2>
    <h2>My age is {{ age }}</h2>
    <h2>My  address  is {{ address }}</h2>
    <h2>My  phone  number  is {{ phone }}</h2>
    <h2>My  email  i s {{ email }}</h2>
</div>

const app = Vue.createApp({

    data() { 
        return {
            name: "Karan",
            age: 21,
            address: "Kathmandu",
            phone: 9812345678,
            email: "karan@outlook.com"
        }
    }
})

var firstNum = 1;
var secondNum = 1;



function onAdd() {
    var result = firstNum + secondNum;
    console.log(result);
}

app.mount('#app')