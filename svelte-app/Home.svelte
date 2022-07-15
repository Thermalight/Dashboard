<script>
    import { currentPage } from "./stores.js";
    import Clock from "./Clock.svelte"

    console.log("Page: " + $currentPage)
</script>

<div class="container">
    <p>Welcome user</p>
    <Clock />
</div>


<style>
    .container {
        background-color: #e7c064;
        border-radius: 5px;
        width: 100%;
        padding-bottom: 9999px; 
        margin-bottom: -9999px
    }
</style>