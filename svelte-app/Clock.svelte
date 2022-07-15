<script>
    import { onMount } from 'svelte';

    let time = new Date();

    onMount(() => {
		const interval = setInterval(() => {
			time = new Date();
		}, 1000);

		return () => {
			clearInterval(interval);
		};
	});

    function formatNumber(num) {
        return `${num <= 9 ? "0" : ""}${num}`
    }

</script>

<div class="frame">
    <p>{formatNumber(time.getHours())}:{formatNumber(time.getMinutes())}:{formatNumber(time.getSeconds())}</p>
</div>


<style>
    p {
        font-size: 50px;
        font-weight: bold;
        color: #F92672;
    }

    .frame {
        background-color: #c5c5c5;
        width: fit-content;
        border-radius: 5px;
        padding-left: 5px;
        padding-right: 5px;
        user-select: none;
    }
</style>