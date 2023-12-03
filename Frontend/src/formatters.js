export const userLocale = navigator.language

export function formatDate(dateToFormat) {
  let date = new Date(dateToFormat)
  return date.toLocaleDateString(userLocale)
}
