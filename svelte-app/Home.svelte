<script>
    import { currentPage } from "./stores.js";
    import Clock from "./Clock.svelte"

    console.log("Page: " + $currentPage)
</script>

<h1>Welcome user</h1>
<Clock />