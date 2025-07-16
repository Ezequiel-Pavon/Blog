<script lang="ts">
  import { slide } from 'svelte/transition';
  let user = {
    name: "Juan Pérez",
    email: "juan.perez@email.com",
    avatar: "https://ui-avatars.com/api/?name=Juan+Pérez"
  };

  let showMenu = false;
  let menuRef: HTMLDivElement;

  function handleClickOutside(event: MouseEvent) {
    if (menuRef && !menuRef.contains(event.target as Node)) {
      showMenu = false;
    }
  }

  if (typeof window !== 'undefined') {
    window.addEventListener('click', handleClickOutside);
  }
</script>

<nav class="sticky top-0 left-0 w-full z-40 bg-white dark:bg-gray-900 shadow-md border-b border-gray-200 dark:border-gray-800">
  <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8 flex items-center h-16">
    <!-- Logo / Brand -->
    <a href="/" class="flex items-center gap-2 font-extrabold text-xl text-blue-600 dark:text-blue-400 tracking-tight">
      <svg class="w-8 h-8" fill="none" stroke="currentColor" stroke-width="2" viewBox="0 0 24 24">
        <circle cx="12" cy="12" r="10" stroke="currentColor" stroke-width="2" fill="none"/>
        <path d="M8 12l2 2 4-4" stroke="currentColor" stroke-width="2" fill="none"/>
      </svg>
      SocialNet
    </a>
    <!-- Centered Auth Buttons -->
    <div class="flex-1 flex justify-center">
      <div class="flex gap-2">
        <button class="px-4 py-2 rounded-full bg-blue-500 text-white font-semibold shadow hover:bg-blue-600 transition">Iniciar sesión</button>
        <button class="px-4 py-2 rounded-full bg-white text-blue-500 border border-blue-500 font-semibold shadow hover:bg-blue-50 dark:bg-gray-800 dark:text-blue-400 dark:border-blue-400 transition">Registrarse</button>
      </div>
    </div>
    <!-- User Button at right -->
    <div class="relative" bind:this={menuRef}>
      <button
        class="flex items-center gap-2 px-3 py-2 rounded-full bg-gray-100 dark:bg-gray-800 hover:bg-blue-100 dark:hover:bg-blue-900 transition"
        on:click={() => showMenu = !showMenu}
        aria-haspopup="true"
        aria-expanded={showMenu}
      >
        <img src={user.avatar} alt={user.name} class="w-8 h-8 rounded-full border-2 border-blue-400" />
        <span class="hidden sm:inline text-gray-700 dark:text-gray-200 font-medium">{user.name}</span>
      </button>
      {#if showMenu}
        <ul
          class="absolute right-0 mt-2 w-56 min-w-[12rem] max-w-xs overflow-x-auto bg-white dark:bg-gray-900 rounded-xl shadow-lg border border-gray-200 dark:border-gray-700 z-50 py-2"
          transition:slide
          style="right:0; left:auto;"
        >
          <li class="flex items-center gap-3 px-4 py-2 border-b border-gray-100 dark:border-gray-800">
            <img src={user.avatar} alt={user.name} class="w-10 h-10 rounded-full border-2 border-blue-400" />
            <div>
              <div class="font-semibold text-gray-900 dark:text-white">{user.name}</div>
              <div class="text-xs text-gray-500">{user.email}</div>
            </div>
          </li>
          <li>
            <button class="w-full text-left px-4 py-2 rounded-b-xl text-blue-600 dark:text-blue-400 hover:bg-blue-50 dark:hover:bg-blue-900 transition">
              Cerrar sesión
            </button>
          </li>
        </ul>
      {/if}
    </div>
  </div>
</nav>