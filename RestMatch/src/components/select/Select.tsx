interface SelectProps {
  children: React.ReactNode
  styles?: string;
}

export const Select = (props: SelectProps) => {
  const { children, styles } = props;
  return (
    <select className={`text-black ${styles}`}>
      {children}
    </select>
  )
}