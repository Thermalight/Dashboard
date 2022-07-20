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
    import { fly } from "svelte/transition";
    import { backOut } from "svelte/easing";

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

<Navbar />

{#key $currentPage}
    <div class="content" transition:fly={{ y: 100, duration: 300, easing: backOut }}>
        <svelte:component this={routing[$currentPage] ?? NotFound} />
    </div>
{/key}

<style>
    .content {
        position: absolute;
        top: 0;
        margin: 2em;
        margin-left: 5em;
        height: calc(100vh - 7em);
        width: 100%;
        overflow: hidden;
        z-index: -1;
    }
</style>
