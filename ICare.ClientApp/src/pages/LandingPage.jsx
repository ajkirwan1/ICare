/** @format */

import { Header } from "components/ui/Header";
import { Footer } from "components/ui/Footer";
import styles from "assets/styles/LandingPage.module.css";

export function LandingPage() {
  return (
    <div>
      <Header></Header>
      <main>
        <div className={styles.landingPageGrid}>
          <div className={styles.item1}>Test</div>
          <div className={styles.item2}>Test</div>
          <div className={styles.item3}>Test</div>
          <div className={styles.item4}>Test</div>
          <div className={styles.item5}>Test</div>
        </div>
      </main>
      <Footer></Footer>
    </div>
  );
}
