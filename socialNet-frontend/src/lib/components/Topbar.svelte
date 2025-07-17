<script lang="ts">
  import { createEventDispatcher, onMount } from 'svelte';
  let search = '';
  let inputEl: HTMLInputElement;
  const dispatch = createEventDispatcher();

  onMount(() => {
    inputEl?.focus();
  });

  function handleInput(e: Event) {
    search = (e.target as HTMLInputElement).value;
    dispatch('search', search);
  }
</script>

<header class="w-full bg-card shadow flex items-center px-6 py-4">
  <input
    bind:this={inputEl}
    type="text"
    placeholder="Buscar…"
    class="w-full max-w-md px-4 py-2 rounded-lg border-2 border-transparent focus:border-primary focus:shadow-lg transition-all duration-300 outline-none bg-bg text-white shadow"
    on:input={handleInput}
  />
</header>
