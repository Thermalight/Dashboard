<script>
    import Link from "./Link.svelte"

    function logout() {
        console.log("Logging out")
    }
</script>

<nav>
    <div class="logo">
        <h1>D</h1>
    </div>

    <div class="links">
        <Link href="/"><span class="material-symbols-outlined">home</span><span>Home</span></Link>
        <Link href="/deadlines"><span class="material-symbols-outlined">description</span><span>Deadlines</span></Link>
        <Link href="/notifications"><span class="material-symbols-outlined">mail</span><span>Notifications</span></Link>
        <Link href="/statistics"><span class="material-symbols-outlined">leaderboard</span><span>Statistics</span></Link>
        <Link href="/settings"><span class="material-symbols-outlined">settings</span><span>Settings</span></Link>
        <button on:click={logout}><span class="material-symbols-outlined">logout</span><span>Logout</span></button>
    </div>
</nav>

<style>
    nav {
        width: 3em;
        height: calc(100vh - 4em);
        margin-top: 2em;
        background-color: var(--color-primary);
        color: white;
        z-index: 999;
        border-radius: 1.5em;
        transition: width .5s ease-in-out;
        box-shadow: .5em .5em 0.75em rgba(0,0,0,0.1);
        overflow: hidden;
    }

    nav:hover {
        width: 200px;
    }

    .logo {
        text-align: center;
        margin-top: 2em;
        margin-bottom: 1em;
    }

    .links :global(a), :global(button) {
        display: flex;
        align-items: center;
        gap: 8px;
        text-decoration: none;
        font-size: 1em;
        padding: .75em 6px;
        color: white;
        transition: width 0.1s ease-in-out;
    }

    .links :global(a):hover, :global(button):hover {
        background: rgba(255,255,255,0.2) !important;
    }

    .links button {
        background: none;
        border: none;
        width: 100%;
        text-align: left;
        cursor: pointer;
    }

    .material-symbols-outlined {
        margin-left: .25em;
        margin-right: .25em;
    }
</style>