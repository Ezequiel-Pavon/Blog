<script lang="ts">
  import { user, notifications } from '../stores';
  import { page } from '$app/stores';
  import { Badge } from 'flowbite-svelte';

  let current: string;
  $: current = $page.url.pathname;

  const links = [
    { name: 'Feed', href: '/feed', icon: 'i-heroicons-home' },
    { name: 'Amigos', href: '/friends', icon: 'i-heroicons-user-group' },
    { name: 'Perfil', href: '/profile', icon: 'i-heroicons-user' }
  ];
</script>

<aside class="bg-card text-white w-64 min-h-screen flex flex-col items-center py-8 shadow-lg sticky top-0 h-screen overflow-auto">
  <!-- Avatar usuario -->
  <div class="mb-8">
    <img src="{$user?.avatar || '/default-avatar.png'}" alt="Avatar" class="w-20 h-20 rounded-full border-4 border-primary shadow" />
    <div class="mt-2 font-bold">{$user?.name || 'Usuario'}</div>
  </div>
  <!-- Navegación -->
  <nav class="flex flex-col gap-2 w-full px-4">
    {#each links as link}
      <a
        href={link.href}
        class="flex items-center gap-3 px-4 py-2 rounded-lg transition relative
          {current === link.href
            ? 'bg-primary text-white shadow font-semibold'
            : 'text-gray-200 bg-card/80 hover:bg-primary/70 hover:text-white'}"
      >
        <span class={link.icon + " text-xl"}></span>
        <span>{link.name}</span>
        {#if link.name === 'Feed' && $notifications > 0}
          <Badge color="pink" class="absolute right-2 animate-bounce">{$notifications}</Badge>
        {/if}
        {#if current === link.href}
          <span class="absolute left-0 top-1/2 -translate-y-1/2 w-1 h-6 bg-pink-400 rounded-r"></span>
        {/if}
      </a>
    {/each}
  </nav>
</aside>


