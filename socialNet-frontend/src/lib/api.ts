// src/lib/api.ts
// Funciones simuladas de fetch para la demo
export async function getFeed() {
  // Simula un fetch a la API
  return [
    {
      id: '1',
      author: { name: 'Juan Pérez', avatar: '/default-avatar.png' },
      date: 'Hace 2 horas',
      image: 'https://picsum.photos/seed/1/600/300',
      body: '¡Hola mundo! Este es mi primer post.',
      liked: false,
      likes: 5
    }
    // ...otros posts
  ];
}

export async function likePost(postId: string) {
  // Simula un like en la API
  return true;
}

export async function getUser() {
  // Simula obtener el usuario actual
  return { name: 'Juan Pérez', avatar: '/default-avatar.png' };
}
