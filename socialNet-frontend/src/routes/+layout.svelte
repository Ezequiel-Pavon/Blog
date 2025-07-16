<script lang="ts">
  import '../app.css';
  import Navbar from '../lib/components/navbar.svelte';
  import Footer from '../lib/components/footer.svelte';
  
  let { children } = $props();
</script>

<Navbar />
<!-- svelte-ignore slot_element_deprecated -->
<div class="pt-20">
  <slot />
</div>