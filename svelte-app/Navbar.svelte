<script>
    import Link from "./Link.svelte"

    function logout() {
        console.log("Logging out")
    }
</script>

<nav>
    <div class="logo">
        <h1>Dashboard</h1>

    </div>
    <div class="links">
        <Link href="/"><span class="material-icons">home</span>Home</Link>
        <Link href="/deadlines"><span class="material-icons">description</span>Deadlines</Link>
        <Link href="/notifications"><span class="material-icons">mail</span>Notifications</Link>
        <Link href="/statistics"><span class="material-icons">leaderboard</span>Statistics</Link>
        <Link href="/settings"><span class="material-icons">settings</span>Settings</Link>
        <button on:click={logout}><span class="material-icons">logout</span>Logout</button>
    </div>
    
</nav>

<style>
    nav {
        position: fixed;
        background-color: #e7c064;
        box-sizing: border-box;
        z-index: 999;
        border-radius: 1em;
        bottom: 32px;
        top: 32px;
    }

    .logo {
        text-align: center;
        margin-bottom: 4em;
        margin-top: 2em;
    }

    .links :global(a), :global(button) {
        display: flex;
        align-items: center;
        gap: 8px;
        text-decoration: none;
        font-size: 1em;
        padding: 16px;
        color: #222;
        transition: 0.1s;
        width: 100%;
    }

    .links :global(a):hover, :global(button):hover {
        background: #f3ce77;
    }

    .links button {
        background: none;
        border: none; 
        position: absolute;
        bottom: 20px;
    }

    .links button:hover {
        background: none;
        border: none;
        background: #f3ce77;
    }


</style>