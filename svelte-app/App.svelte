<script>
    import { currentPage } from "./stores.js";
    import { onDestroy } from "svelte";
    import Navbar from "./Navbar.svelte"
    import NotFound from "./NotFound.svelte";
    import Home from "./Home.svelte";
    import Login from "./Login.svelte";
    import Deadlines from "./Deadlines.svelte";
    import Notifications from "./Notifications.svelte";
    import Statistics from "./Statistics.svelte";
    import Settings from "./Settings.svelte";

    currentPage.set(location.pathname.split(/[/?#]/g)[1]);
    $: document.title = ($currentPage || "home");

    let routing = {
        "": Home,
        "login": Login,
        "deadlines": Deadlines,
        "notifications": Notifications,
        "statistics": Statistics,
        "settings": Settings
    };

    window.addEventListener("popstate", handlePopState);
    onDestroy(() => {
        window.removeEventListener("popstate", handlePopState);
    });

    function handlePopState(e) {
        console.log("Event: " + e)
        currentPage.set(location.pathname.split(/[/?#]/g)[1]);
    }
</script>

<div class="content">
    <Navbar />
    <svelte:component this={routing[$currentPage] ?? NotFound} />
</div>


<style>
    .content {
        height: 90vh;
        display: flex;
        flex-direction: row;
        gap: 1em;
        overflow: hidden;
    }
</style>
