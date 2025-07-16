<script lang="ts">
  import { createEventDispatcher } from 'svelte';
  import { scale } from 'svelte/transition';

  const dispatch = createEventDispatcher();

  export let variant: 'primary' | 'secondary' | 'danger' = 'primary';
  export let type: 'button' | 'submit' = 'button';
  export let disabled = false;
  export const loading = false;
  export let className = ''; // Añadido para manejar clases personalizadas

  const variants = {
    primary: 'bg-blue-600 hover:bg-blue-700 text-white',
    secondary: 'bg-gray-200 hover:bg-gray-300 text-gray-800',
    danger: 'bg-red-600 hover:bg-red-700 text-white'
  };
</script>

<button
  {type}
  {disabled}
  class={`inline-flex items-center justify-center rounded-lg px-4 py-2 text-sm font-medium transition-colors 
    ${variants[variant]} 
    ${disabled ? 'cursor-not-allowed opacity-50' : ''}
    ${className}`}
  on:click
>
  <slot />
</button>