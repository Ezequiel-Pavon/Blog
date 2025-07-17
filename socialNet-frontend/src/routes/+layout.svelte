<script lang="ts">
  import Sidebar from '../lib/components/SideBar.svelte';
  import Topbar from '$lib/components/Topbar.svelte';
  import { user } from '$lib/stores';
  import { getUser } from '$lib/api';
  import { onMount } from 'svelte';
  import '../app.css';

  onMount(async () => {
    user.set(await getUser());
  });
</script>

<div class="flex min-h-screen bg-bg text-white">
  <Sidebar />
  <div class="flex-1 flex flex-col min-w-0">
    <Topbar />
    <main class="flex-1 flex justify-center items-start p-6 overflow-x-auto">
      <div class="w-full max-w-3xl">
        <slot />
      </div>
    </main>
  </div>
</div>